namespace BlazorApp6._0.Pages;

public partial class FormTest 
{
    public CustomValidator customValidator;
    public UserVm UserVm { get; set; } = new ();
    
    private void HandleValidSubmit()
    {
        customValidator?.DisplayErrors(new Dictionary<string, List<string>>()
        {
            { nameof(UserVm.Username), new List<string>() { "Username error", "Username second error" } },
            {  nameof(UserVm.AddressVm.Street), new List<string>() { "Street Address error", " second street address error" } }
        });
    }
}