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
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary