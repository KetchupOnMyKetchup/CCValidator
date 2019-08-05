$files = gci $Env:BUILD_SOURCESDIRECTORY -Recurse -Include "*Properties*" | ?{ $_.PSIsContainer } | foreach { gci -Path $_.FullName -Recurse -Include AndroidManifest.* }

if ($files)
{
    Write-Verbose "Updating $($files.count) files";
    foreach ($file in $files)
    {
        $xml = [xml](Get-Content $file);
        $node = $xml.manifest;
        $versionCode = [int]((Get-Date).ToUniversalTime().ToString("yyMMddHHmm"));
        $node.SetAttribute("android:versionCode", $versionCode);
        $node.SetAttribute("android:versionName", $Env:BUILD_BUILDNUMBER);
        $xml.Save($file);
    }
}