dotnet tool install --global autosdk.cli --prerelease
curl -o openapi.yaml https://api.deepinfra.com/openapi.json
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
  echo "Failed, exiting..."
  exit 1
fi
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
