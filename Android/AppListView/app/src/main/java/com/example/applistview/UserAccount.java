package com.example.applistview;

public class UserAccount {
    private String userName;
    private String userType;
    private Boolean active;

    public UserAccount(String UserName,String UserType)
    {
        this.userName=UserName;
        this.userType=UserType;
        this.active=true;
    }

    public UserAccount(String UserName,String UserType,Boolean Active)
    {
        this.userName=UserName;
        this.userType=UserType;
        this.active=Active;
    }

    public String GetUserName()
    {
        return this.userName;
    }

    public void SetUserName(String userName)
    {
        this.userName=userName;
    }

    public String GetUserType()
    {
        return this.userType;
    }

    public void SetUserType(String userType)
    {
        this.userType=userType;
    }

    public Boolean isActive()
    {
        return this.active;
    }

    public void SetActive(Boolean active)
    {
        this.active=active;
    }

    @Override
    public String toString()
    {
        return this.userName+"("+this.userType+")";
    }


}
