using Microsoft.AspNetCore.Components;

namespace LiurenWintry.Layout;

partial class ErrorBoundaryContent
{
    [Parameter]
    public Exception? Exception { get; set; }
}