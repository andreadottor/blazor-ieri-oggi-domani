namespace Dottor.Blazor.Demo2.Client.Components;

using Dottor.Blazor.Demo2.Client.Attributes;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

public partial class DynamicForm<TItem>
{
    [Parameter]
    public string Title { get; set; } = "Dynamic Form";

    [Parameter]
    public TItem? Item { get; set; }

    [Parameter]
    public EventCallback<TItem> ItemChanged { get; set; }

    [Parameter]
    public EventCallback<TItem> OnSave { get; set; }

    [Parameter]
    public EventCallback OnUndo { get; set; }

    protected async Task OnSaveAsync()
    {
        if(OnSave.HasDelegate)
            await OnSave.InvokeAsync(Item);
    }

    protected async Task OnCancelAsync()
    {
        if (OnUndo.HasDelegate)
            await OnUndo.InvokeAsync();
    }

    private IEnumerable<PropertyInfo> GetProperties()
    {
        if (Item is null)
            return [];

        var properties = Item.GetType().GetProperties();

        properties = properties.OrderBy(p =>
        {
            var attribute = p.GetCustomAttribute<FieldIndexAttribute>();
            return attribute?.Index ?? int.MaxValue;
        }).ToArray();

        return properties;
    }

    private string GetLabel(PropertyInfo property)
    {
        var displayName = property.GetCustomAttribute<DisplayNameAttribute>();
        return displayName?.DisplayName ?? property.Name;
    }

    private T? GetPropertyValue<T>(PropertyInfo property)
    {
        if (Item is not null)
        {
            var value = property.GetValue(Item);
            if (value is not null)
                return (T)value;
        }

        return default;
    }

    private Expression<Func<T>> ValueExpression<T>(PropertyInfo property)
    {
        var constant = Expression.Constant(Item);
        var exp = Expression.Property(constant, property);
        return Expression.Lambda<Func<T>>(exp);
    }

}
