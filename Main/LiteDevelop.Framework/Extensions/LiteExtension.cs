﻿using System;
using System.Linq;

namespace LiteDevelop.Framework.Extensions
{
    /// <summary>
    /// The base class for every LiteDevelop extension.
    /// </summary>
    public abstract class LiteExtension : IDisposable
    {

        /// <summary>
        /// Gets the name of this extension.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets a description about this extension.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Gets the author of this extension.
        /// </summary>
        public abstract string Author { get; }

        /// <summary>
        /// Gets additional release information about this extension, such as a list of contributors and used libraries.
        /// </summary>
        public virtual string ReleaseInformation { get { return string.Empty; } }

        /// <summary>
        /// Gets the version of this extension.
        /// </summary>
        public abstract Version Version { get; }

        /// <summary>
        /// Gets the copyright of this extension.
        /// </summary>
        public abstract string Copyright { get; }

        /// <summary>
        /// Initializes the extension.
        /// </summary>
        /// <param name="context">The initialization context to use for initializing the extension.</param>
        public abstract void Initialize(InitializationContext context);

        /// <inheritdoc />
        public virtual void Dispose()
        {
        }

    }
}
