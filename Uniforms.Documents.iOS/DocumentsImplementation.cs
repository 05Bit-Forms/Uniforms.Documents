using System;
using System.IO;
using System.Text;
using Uniforms.Documents;
using Uniforms.Documents.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(DocumentsImplementation))]

namespace Uniforms.Documents.iOS
{
    public class DocumentsImplementation : IDocuments
    {
        #region IDocuments implementation

        public string LoadTextAsset(string fileName, Encoding encoding = null)
        {
            return File.ReadAllText(fileName, encoding ?? Encoding.UTF8);
        }

        #endregion
    }
}

