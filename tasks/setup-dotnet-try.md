# DotNet Try

<!--
#dotnet #fsharp #tutorial #task
-->

## Prerequisites

- Install DotNet Core
- Understand DotNet global tools
- Install Jupyter (for Jupyter notebook usage)

## Setup

### Install

```bash
dotnet tool install --global dotnet-try
```

### Update to Latest Version

```bash
dotnet tool update --global dotnet-try
```

## Usage

### Run Demo

```bash
dotnet try demo
```

### Run

```bash
dotnet try
```

Note: need to `cd` to proper directory before run this command

## Use Jupyter for FSharp

### Install Jupyter Kernel

```bash
dotnet try jupyter install
```

### List Jupyter Kernels

```bash
jupyter kernelspec list
```

### Start Jupyter Lab

```bash
jupyter lab
```

## Links

- GitHub Repo: https://github.com/dotnet/try
- Jupyter notebook: https://devblogs.microsoft.com/dotnet/net-core-with-juypter-notebooks-is-here-preview-1/
