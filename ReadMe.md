# A "simplest possible" cross-platform binary PowerShell module

I needed to know the answer to the questions:

## Is it possible to make a cross-platform binary PowerShell module?

## Can a single assembly works in both Windows PowerShell and PowerShell Core?

The answer is: Yes.

This project is the proof of concept, and a simple template. It doesn't do anything useful, except compile, and ... you know ... work.

## Build Instructions

```posh
git clone https://github.com/jaykul/NetCoreModuleProof.git
cd NetCoreModuleProof

dotnet restore
dotnet Build

Import-Module ./bin/debug/netstandard1.6/NetCoreModuleProof.dll

Get-Command NetCoreModuleProof
Get-Greeting
```

That's really all there is to it.  Feel free to copy and add your own useful commands!