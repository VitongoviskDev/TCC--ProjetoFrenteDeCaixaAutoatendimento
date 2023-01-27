using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ubiety.Dns.Core.Records.NotUsed;

namespace Projeto_frente_de_Caixa.Control
{
    public class CompanyControll
    {
        public bool ValidateCnpj(CompanyModel company)
        {
            string cnpj = company.Cnpj;
            if(cnpj.Length != 14)
                return false;

            double soma = 0;

            soma += int.Parse(cnpj[0].ToString()) * 5;
            soma += int.Parse(cnpj[1].ToString()) * 4;
            soma += int.Parse(cnpj[2].ToString()) * 3;
            soma += int.Parse(cnpj[3].ToString()) * 2;
            soma += int.Parse(cnpj[4].ToString()) * 9;
            soma += int.Parse(cnpj[5].ToString()) * 8;
            soma += int.Parse(cnpj[6].ToString()) * 7;
            soma += int.Parse(cnpj[7].ToString()) * 6;
            soma += int.Parse(cnpj[8].ToString()) * 5;
            soma += int.Parse(cnpj[9].ToString()) * 4;
            soma += int.Parse(cnpj[10].ToString()) * 3;
            soma += int.Parse(cnpj[11].ToString()) * 2;

            int rest = (int)Math.Round(soma % 11);

            int first = rest < 2 ? 0 : 11 - rest;

            soma = 0;
            soma += int.Parse(cnpj[0].ToString()) * 6;
            soma += int.Parse(cnpj[1].ToString()) * 5;
            soma += int.Parse(cnpj[2].ToString()) * 4;
            soma += int.Parse(cnpj[3].ToString()) * 3;
            soma += int.Parse(cnpj[4].ToString()) * 2;
            soma += int.Parse(cnpj[5].ToString()) * 9;
            soma += int.Parse(cnpj[6].ToString()) * 8;
            soma += int.Parse(cnpj[7].ToString()) * 7;
            soma += int.Parse(cnpj[8].ToString()) * 6;
            soma += int.Parse(cnpj[9].ToString()) * 5;
            soma += int.Parse(cnpj[10].ToString()) * 4;
            soma += int.Parse(cnpj[11].ToString()) * 3;
            soma += int.Parse(cnpj[12].ToString()) * 2;

            rest = (int)Math.Round(soma % 11);

            int second = rest < 2 ? 0 : 11 - rest;

            if (int.Parse(cnpj[12].ToString()) != first || int.Parse(cnpj[13].ToString()) != second)
                return false;

            return true;
        }
        public bool ValidateStateRegistration(CompanyModel company)
        {
            if(company.StateRegistration.Length != 13)
                return false;

            return true;
        }
        public CompanyModel GetCompanyById(CompanyModel company)
        {
            CompanyDao companyDao = new CompanyDao();
            return companyDao.GetCompanyByID(company);
        }
        public static CompanyModel GetMainCompany()
        {
            CompanyDao companyDao = new CompanyDao();
            return companyDao.GetCompanyByID(new CompanyModel() { Id = 1});
        }
        public void UpdateCompany(CompanyModel company)
        {
            CompanyDao companyDao = new CompanyDao();
            companyDao.UpdateCompany(company);
        }
        public void AddMainCompany(CompanyModel company)
        {
            CompanyDao companyDao = new CompanyDao();
            companyDao.AddMainCompany(company);
        }
        public int AddCompany(CompanyModel company)
        {
            CompanyDao companyDao = new CompanyDao();
            return companyDao.AddCompany(company);
        }
        public CompanyModel GetCompanyByCnpj(CompanyModel company)
        {
            CompanyDao companyDao = new CompanyDao();
            return companyDao.GetCompanyByCnpj(company);
        }
    }
}
