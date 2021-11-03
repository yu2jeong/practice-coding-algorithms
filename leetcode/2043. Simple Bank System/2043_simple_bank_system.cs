public class Bank {
    
    private long[] balance;
    
    public Bank(long[] balance) {
        this.balance = balance;
    }
    
    public bool Transfer(int account1, int account2, long money) {
        if(IsValidAccount(account1) && IsValidAccount(account2))
        {
            if(IsEnoughMoney(account1, money))
            {
                balance[account1-1] -= money;
                balance[account2-1] += money;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    
    public bool Deposit(int account, long money) {
        if(IsValidAccount(account))
        {
            balance[account-1] += money;
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public bool Withdraw(int account, long money) {
        if(IsValidAccount(account))
        {
            if(IsEnoughMoney(account,money))
            {
                balance[account-1] -= money;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    
    private bool IsValidAccount(int account)
    {
        if(account > 0 && account <= balance.Length )
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    private bool IsEnoughMoney(int account, long money)
    {
        if(balance[account-1] < money)
        {
            return false;
        }
        return true;
    }
}
