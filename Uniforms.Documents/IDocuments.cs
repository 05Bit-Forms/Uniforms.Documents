using System;
using System.IO;
using System.Text;

namespace Uniforms.Documents
{
    /// <summary>
    /// Documents utils interface.
    /// </summary>
    public interface IDocuments
    {
        /// <summary>
        /// Loads the text asset.
        /// </summary>
        /// <param name="fileName">Path to text asset file.</param>
        /// <param name="encoding">Text encoding, default is UTF-8.</param>
        string LoadTextAsset(string fileName, Encoding encoding = null);
    }
}

