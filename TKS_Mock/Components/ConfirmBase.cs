using Microsoft.AspNetCore.Components;
namespace TKS_Mock.Components
{
    public class ConfirmBase : ComponentBase
    {
        protected bool ShowConfirmation {  get; set; }
        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }
        [Parameter]
        public EventCallback<bool> OnConfirmed { get; set; }

        protected async Task Confirm(bool value)
        {
            ShowConfirmation = false;
            await OnConfirmed.InvokeAsync(value);
        }
    }
}
