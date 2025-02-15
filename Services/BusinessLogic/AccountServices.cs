using Core.Entities;
using Core.Interfaces;
using Dapper;
using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BusinessLogic
{
    public class AccountServices : IAccountServices
    {
        private readonly DapperDBContext _dbContext;
        public AccountServices(DapperDBContext dapperDBContext)
        {
            _dbContext = dapperDBContext;
        }
        public AppUsers.Details GetLogin(AppUsers.Login model)
        {
            AppUsers.Details result = new AppUsers.Details();
            try
            {
                using var connection = _dbContext.CreateConnection();
                var param = new DynamicParameters();
                param.Add("@UserID", value: model.UserID ?? "", DbType.String, ParameterDirection.Input);
                param.Add("@Password", value: model.Password ?? "", DbType.String, ParameterDirection.Input);
                param.Add("@EntrySource", value: model.LoginInfo ?? "", DbType.String, ParameterDirection.Input);
                using (var reader = connection.QueryMultiple("spu_GetLogin", param: param, commandType: CommandType.StoredProcedure))
                {
                    result = reader.Read<AppUsers.Details>().FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
