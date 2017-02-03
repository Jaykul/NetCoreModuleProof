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

## You probably know, intuitively, that this is too good to be true

Well, you're basically right.

This module does indeed work in a cross-platform way, with no problems. However, that's because it has virtually no dependencies -- it doesn't even use a hashtable parameter, or use `System.Math`.  Unfortunately, as soon as you start adding dependencies, you will start running into problems, because many of your dependencies won't "just work" on both Full Framework and Core Framework -- you'll need to cross-compile.

The problem is, once you cross-compile, how can we load _the right_ dependent assemblies on PowerShell Core, running on .Net Core, and on Windows PowerShell, running on the full .Net Framework 4.x?

Right now, as far as I know, the answer is: you cannot, in PowerShell.  I have [filed this issue](https://github.com/PowerShell/PowerShell/issues/3091) because I could not find an older one...
