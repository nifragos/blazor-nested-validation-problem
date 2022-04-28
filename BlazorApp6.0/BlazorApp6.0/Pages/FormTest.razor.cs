namespace BlazorApp6._0.Pages;

public partial class FormTest 
{
    public CustomValidator customValidator;
    public UserVm userVm { get; set; } = new ();
    
    private void HandleValidSubmit()
    {
        customValidator?.DisplayErrors(new Dictionary<string, List<string>>()
        {
            { nameof(userVm.Username), new List<string>() { "Username error", "Username second error" } },
            {  nameof(userVm.AddressVm.Street), new List<string>() { "Street Address error", " second street address error" } }
        });
    }
}