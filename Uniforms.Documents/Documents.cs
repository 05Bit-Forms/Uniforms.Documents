using System;
using System.Text;
using Xamarin.Forms;

namespace Uniforms.Documents
{
    public static class Documents
    {
        static Lazy<IDocuments> impl = new Lazy<IDocuments>(
            () => CreateInstance(),
            System.Threading.LazyThreadSafetyMode.PublicationOnly);

        static IDocuments CreateInstance()
        {
            return DependencyService.Get<IDocuments>();
        }

        public static string LoadTextAsset(string fileName, Encoding encoding = null)
        {
            return impl.Value.LoadTextAsset(fileName, encoding ?? Encoding.UTF8);
        }
    }
}

