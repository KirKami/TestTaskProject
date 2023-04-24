using System;

[Serializable]
public class PlayerCurrency
{
    public enum CurrencyType
    {
        currency,
        lives,
        turns,
    }

    private ulong currency = 1000;
    private uint lives = 5;
    private uint turns = 10;

    #region NETWORK GETTERS
    public ulong GetCurrency()
    {
        return currency;
    }
    public uint GetLives()
    {
        return lives;
    }
    public uint GetTurns()
    {
        return turns;
    }
    #endregion
    #region NETWORK SETTERS
    public void SetCurrency(CurrencyType type, int addAmount)
    {
        switch (type)
        {
            case CurrencyType.currency:
                if (addAmount >= 0)
                {
                    currency += Convert.ToUInt32(addAmount);
                }
                else
                {
                    addAmount *= -1;
                    currency -= Convert.ToUInt32(addAmount);
                }
                return;
            case CurrencyType.lives:
                if (addAmount >= 0)
                {
                    lives += Convert.ToUInt32(addAmount);
                }
                else
                {
                    addAmount *= -1;
                    lives -= Convert.ToUInt32(addAmount);
                }
                return;
            case CurrencyType.turns:
                if (addAmount >= 0)
                {
                    turns += Convert.ToUInt32(addAmount);
                }
                else
                {
                    addAmount *= -1;
                    turns -= Convert.ToUInt32(addAmount);
                }
                return;
        }
        throw new ArgumentException("Invalid value", "value");
    }
    #endregion
}

