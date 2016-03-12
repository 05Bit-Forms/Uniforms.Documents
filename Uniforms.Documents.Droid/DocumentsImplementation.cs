using System;
using System.IO;
using System.Text;
using Android.Content;
using Xamarin.Forms;
using Uniforms.Documents.Droid;

[assembly: Dependency(typeof(DocumentsImplementation))]

namespace Uniforms.Documents.Droid
{
    public class DocumentsImplementation : IDocuments
    {
        #region IDocuments implementation

        public string LoadTextAsset(string fileName, Encoding encoding = null)
        {
            var context = Android.App.Application.Context;
            var asset = context.Assets.Open(fileName);
            var reader = new StreamReader(asset, encoding ?? Encoding.UTF8);
            return reader.ReadToEnd();
        }

        #endregion
    }
}

