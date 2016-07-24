namespace DocumentSystem.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IEncryptable
    {
        bool IsEncrypted { get; }
        void Encrypt();
        void Decrypt();
    }
}