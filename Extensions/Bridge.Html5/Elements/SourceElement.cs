﻿using System;
using Bridge.CLR;

namespace Bridge.Html5
{
    /// <summary>
    /// The HTMLSourceElement interface provides special properties (beyond the regular HTMLElement object interface it also has available to it by inheritance) for manipulating <source> elements.
    /// </summary>
    [Ignore]
    [Name("HTMLSourceElement")]
    public class SourceElement : Element
    {
        [Template("document.createElement('source')")]
        public SourceElement()
        {
        }

        /// <summary>
        /// Reflects the media HTML attribute, containing the intended type of the media resource.
        /// </summary>
        public string Media;

        /// <summary>
        /// Reflects the src HTML attribute, containing the URL for the media resource.
        /// </summary>
        public string Src;

        /// <summary>
        /// Reflects the type HTML attribute, containing the type of the media resource.
        /// </summary>
        public string Type;
    }
}