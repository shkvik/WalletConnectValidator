using WalletConnectSharp.Core.Models;
using WalletConnectSharp.Core.Network;
using WalletConnectSharp.Core.Utils;

namespace WalletConnectValidator.Validators
{
    static class HMAC
    {
        private static ICipher Cipher = new AESCipher();

        public static async Task<bool> Decrypte()
        {
            Console.Write("Input iv:");
            var c_iv = Console.ReadLine();

            Console.Write("Input hmac:");
            var c_hmac = Console.ReadLine();

            Console.Write("Input data:");
            var c_data = Console.ReadLine();

            Console.Write("Input key:");
            var c_key = Console.ReadLine();

            var encryptedPayload = new EncryptedPayload()
            {
                iv = c_iv,
                hmac = c_hmac,
                data = c_data
            };

            byte[] key = c_key.HexToByteArray();

            Console.Write(await Cipher.DecryptWithKey(key, encryptedPayload));

            return true;
        }
    }
}
