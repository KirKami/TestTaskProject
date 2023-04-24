using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;

[Serializable]
public class MaterialCurrency
{
    public enum CurrencyType
    {
        candy,
        parts,
        pieces,
        sticks,
        aether,
    }

    private uint candy = 10;
    private uint parts = 10;
    private uint pieces = 10;
    private uint sticks = 10;
    private uint aether = 10;

    #region NETWORK GETTERS
    public uint GetMaterial(CurrencyType type)
    {
        switch (type)
        {
            case CurrencyType.candy:
                return candy;
            case CurrencyType.parts:
                return parts;
            case CurrencyType.pieces:
                return candy;
            case CurrencyType.sticks:
                return candy;
            case CurrencyType.aether:
                return candy;
        }
        throw new ArgumentException("Invalid value","value");
    }
    #endregion
    #region NETWORK SETTERS
    public void SetMaterial(CurrencyType type, int addAmount)
    {
        switch (type)
        {
            case CurrencyType.candy:
                if (addAmount >= 0)
                {
                    candy += Convert.ToUInt32(addAmount);
                }
                else
                {
                    addAmount *= -1;
                    candy -= Convert.ToUInt32(addAmount);
                }
                return;
            case CurrencyType.parts:
                if (addAmount >= 0)
                {
                    parts += Convert.ToUInt32(addAmount);
                }
                else
                {
                    addAmount *= -1;
                    parts -= Convert.ToUInt32(addAmount);
                }
                return;
            case CurrencyType.pieces:
                if (addAmount >= 0)
                {
                    pieces += Convert.ToUInt32(addAmount);
                }
                else
                {
                    addAmount *= -1;
                    pieces -= Convert.ToUInt32(addAmount);
                }
                return;
            case CurrencyType.sticks:
                if (addAmount >= 0)
                {
                    sticks += Convert.ToUInt32(addAmount);
                }
                else
                {
                    addAmount *= -1;
                    sticks -= Convert.ToUInt32(addAmount);
                }
                return;
            case CurrencyType.aether:
                if (addAmount >= 0)
                {
                    aether += Convert.ToUInt32(addAmount);
                }
                else
                {
                    addAmount *= -1;
                    aether -= Convert.ToUInt32(addAmount);
                }
                return;
        }
        throw new ArgumentException("Invalid value", "value");
    }
    #endregion
}