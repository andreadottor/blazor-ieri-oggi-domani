namespace Dottor.Blazor.Demo2.Client.Components;

using Microsoft.AspNetCore.Components;

public partial class FieldText
{
    [Parameter]
    public string Label { get; set; } = default!;
}
