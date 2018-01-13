# Media-Extractor
Media Extractor is an application to preview and extract packed media in Microsoft Office files (e.g. Word, PowerPoint or Excel documents)

## Current State

* Supports most of the new Office formats (e.g. docx, xlsx, pptx)
* Supports archive formats (e.g. zip, tar, 7z)
* Creates previews of the most common image formats used in Office (e.g. png, jpg, emf)
* Supports export of all media files at once or individual
* Supports export of other embedded Office data (e.g. xml files in xlsx or docx)


## Requirements / Dependencies

* .NET 4.5 or higher
* SevenZipExtractor (maintained by NuGet)
* WindowsAPICodePack-Core (maintained by NuGet)
* WindowsAPICodePack-Shell (maintained by NuGet)


## Known Issues / ToDo

* If a file is already opened by another application, Media Extractor will be locked (error is not handled properly at the moment)
* The overwrite files dialog is broken at the moment