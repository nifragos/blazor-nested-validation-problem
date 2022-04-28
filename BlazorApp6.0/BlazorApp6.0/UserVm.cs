using System.ComponentModel.DataAnnotations;

namespace BlazorApp6._0;

public class UserVm
{
    public string Username { get; set; }

    public AddressVm AddressVm { get; set; } = new AddressVm();

}

public class AddressVm
{
    public string Street { get; set; }
}