using WalletConnectValidator.Validators;

namespace WalletConnectValidator;

public static class WalletConnectValidator 
{

    public delegate Task<bool> CryptopMethod();

    private static Dictionary<string, CryptopMethod>? _methodsDictionary = new Dictionary<string, CryptopMethod>()
    {
        { "hmac", delegate { return HMAC.Decrypte(); }  }
    };

    private static async Task Main(string[] args)
    {
        var test = _methodsDictionary["hmac"].Invoke();
    }
}