﻿namespace Masa.Blazor.Experimental.Components;

public class PopupComponentBase : ComponentBase
{
    [CascadingParameter]
    protected MasaPopupProvider? MasaPopupProvider { get; set; }

    [CascadingParameter]
    protected ProviderItem? PopupItem { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? Attributes { get; set; }

    protected bool Visible { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Visible = true;
    }
}