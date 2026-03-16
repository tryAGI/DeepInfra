dotnet tool install --global autosdk.cli --prerelease
curl -o openapi.yaml https://api.deepinfra.com/openapi.json
if ! command -v jq >/dev/null 2>&1; then
  echo "jq is required to patch the downloaded OpenAPI spec." >&2
  exit 1
fi

tmp_openapi="$(mktemp)"
jq '
  if .components.schemas.TimeInterval.properties.to? then
    .components.schemas.TimeInterval.properties.to.format = "int64" |
    .components.schemas.TimeInterval.properties.to.default |=
      (if type == "string" and test("^-?[0-9]+$") then tonumber else . end)
  else
    .
  end |
  .components.schemas.DeploymentOut.properties.type.default = null |
  .components.schemas.DeployModelIn.properties.provider.default = null |
  .components.schemas.OpenAITextToSpeechIn.properties.voice.default = null |
  .components.schemas.OpenAITextToSpeechIn.properties.response_format.default = null
' openapi.yaml > "$tmp_openapi" && mv "$tmp_openapi" openapi.yaml

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace DeepInfra \
  --clientClassName DeepInfraClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary \
  --base-url https://api.deepinfra.com/ \
  --security-scheme Http:Header:Bearer
