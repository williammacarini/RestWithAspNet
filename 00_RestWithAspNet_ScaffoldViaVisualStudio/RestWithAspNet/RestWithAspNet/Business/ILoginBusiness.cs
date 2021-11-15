using RestWithAspNet.Data.VO;

namespace RestWithAspNet.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidadeCredentials(UserVO user);
        TokenVO ValidadeCredentials(TokenVO token);
        bool RevokeToken(string userName);
    }
}
