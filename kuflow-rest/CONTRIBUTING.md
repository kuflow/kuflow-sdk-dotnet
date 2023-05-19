# Developing kuflow-rest

This doc is intended for contributors to `kuflow-rest`

## Development Environment

- .Net Core: 6.0.408
- NodeJs >= 18

The project uses [Azure Autorest](https://github.com/Azure/autorest) for the generation of a client based on the OpenApi specification of the KuFlow Api rest.

## Build

### Generator tool

In the folder 'kuflow-rest/etc/openapi' resides the configuration of the Node.js project necessary for the creation of the client. You can read the [readme](etc/openapi/readme.md) file located in this directory to see the configurations and modifications made in the code generation tool.
You can refer to the official Azure AutoRest documentation for more information.
