This fork removes SkiaSharp dependency.

Original readme follows:

iTextSharp.LGPLv2.Core
======================

[![iTextSharp.LGPLv2.Core](https://github.com/VahidN/iTextSharp.LGPLv2.Core/workflows/.NET%20Core%20Build/badge.svg)](https://github.com/VahidN/iTextSharp.LGPLv2.Core)

`iTextSharp.LGPLv2.Core` is an **unofficial** port of the last [LGPL version](http://www.gnu.org/licenses/old-licenses/lgpl-2.0-standalone.html) of the [iTextSharp (V4.1.6)](https://github.com/itextsharper/iTextSharp-4.1.6) to .NET Core.


Install via NuGet
-----------------
To install iTextSharp.LGPLv2.Core, run the following command in the Package Manager Console:

[![Nuget](https://img.shields.io/nuget/v/iTextSharp.LGPLv2.Core)](http://www.nuget.org/packages/iTextSharp.LGPLv2.Core/)
```
PM> Install-Package iTextSharp.LGPLv2.Core
```

You can also view the [package page](http://www.nuget.org/packages/iTextSharp.LGPLv2.Core/) on NuGet.

Usage
------
[Functional Tests](https://github.com/VahidN/iTextSharp.LGPLv2.Core/tree/master/src/iTextSharp.LGPLv2.Core.FunctionalTests)


FAQ
-----------------
 > The pdf is created, but when I try to view it, it says that the document is in use by another process.

 You should dispose the FileStream/MemoryStream [explicitly](https://github.com/VahidN/iTextSharp.LGPLv2.Core/blob/master/src/iTextSharp.LGPLv2.Core.FunctionalTests/iTextExamples/Chapter11Tests.cs#L69). It won't be closed and disposed automatically at the end.

 > I can't find what would be the equivalent of the PdfTextExtractor class.

 PdfTextExtractor exists in v5.0.2+ with AGPL license (Current project is based on the iTextSharp 4.x, not 5.x).

 > It can't display Unicode characters.

 You can find more samples about how to define and use Unicode fonts [here](https://github.com/VahidN/iTextSharp.LGPLv2.Core/blob/master/src/iTextSharp.LGPLv2.Core.FunctionalTests/iTextExamples/Chapter11Tests.cs).

 > Table rowspans don't work correctly.

 This version which is based on iTextSharp V4.1.6 doesn't support rowspans correctly (iTextSharp supports row spans correctly since v5.4.3, not before that). A solution based on the current version: use `nested tables` to simulate it.

 > iTextSharp.text.html.simpleparser.HTMLWorker does not exist.

 It has been renamed to [HtmlWorker](https://github.com/VahidN/iTextSharp.LGPLv2.Core/blob/master/src/iTextSharp.LGPLv2.Core.FunctionalTests/HtmlWorkerTests.cs#L42).

Licensing
---------
You have three license choices when it comes to iTextSharp: LGPL/MPL, AGPL, or a commercial license. The LGPL/MPL license is only an option with the older 4.1.6 version (used here). After that version, they switched to a dual AGPL/Commercial.

If you need a more recent version, you either have to make your project open-source or pay the license fee.
