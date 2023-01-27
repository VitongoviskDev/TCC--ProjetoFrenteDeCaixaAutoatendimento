using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Control
{
    public class CardControll
    {
        public CardModel GetDebitCard()
        {
            CardDao cardDao = new CardDao();
            return cardDao.GetDebitCard();
        }
        public CardModel GetCreditCard()
        {
        CardDao cardDao = new CardDao();
            return cardDao.GetCreditCard();
        }

        public void RemoveAmount(CardModel card, decimal totalValue)
        {
            CardDao cardDao = new CardDao();
            card.Amount -= totalValue;
            cardDao.UpdateAmount(card);
        }
    }
}
