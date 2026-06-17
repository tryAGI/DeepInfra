#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://api.deepinfra.com/openapi.json
install_autosdk_cli
fetch_spec --fail --silent --show-error -L -o openapi.json https://api.deepinfra.com/openapi.json

rm -rf Generated
autosdk generate openapi.json \
  --namespace DeepInfra \
  --clientClassName DeepInfraClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary \
  --base-url https://api.deepinfra.com/ \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/DeepInfra.CLI

autosdk cli-project openapi.json \
  --output ../../cli/DeepInfra.CLI \
  --sdk-project ../../libs/DeepInfra/DeepInfra.csproj \
  --targetFramework net10.0 \
  --namespace DeepInfra \
  --clientClassName DeepInfraClient \
  --package-id DeepInfra.CLI \
  --tool-command-name deep-infra \
  --user-secrets-id DeepInfra.CLI \
  --api-key-env-var DEEPINFRA_API_KEY \
  --base-url-env-var DEEPINFRA_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary \
  --base-url https://api.deepinfra.com/ \
  --security-scheme Http:Header:Bearer
