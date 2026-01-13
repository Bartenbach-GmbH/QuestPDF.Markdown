using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPDF.Markdown.Extensions
{
    internal static class PreviewExtensions
    {
        internal static IContainer Preview(this IContainer container, string text, bool show) =>
            !string.IsNullOrEmpty(text) && show ? container.DebugArea(text, Colors.Blue.Darken1) : container;         
    }
}
