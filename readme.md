Rhino Mocks
======================================================================

_Version: 3.6.3.0 (vNext - unreleased)_

* Updated psake to trunk version (https://github.com/psake/psake - a20bd7f52f20cc60a6b885fb02cfa1f492cec9a4).

_Version: 3.6.2.0_

* Better encapsulation of the ordered AAA API.
* Fixed corner case bug when working with nested recorders ([reported by honggoff](https://groups.google.com/d/topic/rhinomocks/tMAbfs2qBec/discussion)).
* Avoid unnecessary first chance NotImplementedExcption if abstract method is called in the constructor of a mocked object.
* Fixed bug introduced during Castle.Core update (affects v3.6.1).
* Applied patch for fixing event raiser to be callable with nullable arguments from romanfq.
* Updated xunit to v1.9.1.

_Version: 3.6.1.0_

* Added support for (generic) multi stubs.
* Applied patch for ordered AAA syntax from Kenneth Xu. [See his blog](http://kennethxu.blogspot.com/2009/06/rhinomocks-ordered-expectations.html)
* Updated to Castle.Core 3.0.0.
* Removed depricated API parts.
* Various bug fixes.

## Links/Resources

* [Rhino Mocks Wiki](http://www.ayende.com/wiki/Rhino+Mocks.ashx "Rhino Mocks Wiki")
* [Rhino Mocks 4.0 Planning](http://nhprof.uservoice.com/pages/28152-rhino-mocks-4-0 "Rhino 4.0 Planning")