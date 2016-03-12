#!/bin/sh

rm Uniforms.Documents*.dll
rm Uniforms.Documents*.mdb
rm Uniforms.Documents*.nupkg

cp ../Uniforms.Documents/bin/Release/Uniforms.Documents.dll* .
cp ../Uniforms.Documents.Droid/bin/Release/Uniforms.Documents.Droid.dll* .
cp ../Uniforms.Documents.iOS/bin/Release/Uniforms.Documents.iOS.dll* .

nuget pack Uniforms.Documents.nuspec