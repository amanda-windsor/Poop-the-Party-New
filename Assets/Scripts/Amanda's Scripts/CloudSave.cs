/*using Unity.Services.Core;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using System.Runtime.InteropServices;
using System.Diagnostics.Contracts;
using System.Collections.Generic;

public class CloudSave : MonoBehaviour
{
    await UnityServices.InitializeAsync();
    await AuthenticationService.Instance.SignInAnonymouslyAsync();
    var data = new Dictionary<string, object> { { "MySaveKey", "HelloWorld" } };
    //await CloudSaveService.Instance.Data.ForceSaveAsync(data);
}
*/