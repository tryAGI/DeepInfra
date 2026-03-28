#!/usr/bin/env bash
set -euo pipefail
dotnet tool install --global autosdk.cli --prerelease
curl --fail --silent --show-error -o openapi.json https://api.deepinfra.com/openapi.json

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
