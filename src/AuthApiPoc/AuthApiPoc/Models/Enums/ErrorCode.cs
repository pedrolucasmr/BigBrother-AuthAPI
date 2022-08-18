using System.ComponentModel;

namespace AuthApiPoc.Models.Enums
{
    public enum ErrorCode
    {
        [Description("An Unknown Error Has Ocurried")]
        Undefined,

        [Description("Email already in use")]
        UserAlreadyExists,

        [Description("An Error Has Occured, please try again later")]
        InternalServerError
    }
}
