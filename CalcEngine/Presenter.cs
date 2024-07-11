using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEngine
{
    public class Presenter
    {
        IView _view;
        Model model = new Model();


        public Presenter(IView view)
        {

            _view = view;

            /*_view.GetSum(model.Sum(_view.firstnumber, _view.secondnumber)); */
            _view.SumSetted += new EventHandler<EventArgs>(OnSetSum);

            _view.Minusing += _view_Minusing;
            _view.Multiplying += _view_Multiplying;
            _view.Dividing += _view_Dividing;
            /* _view.IsSkiped();*/
            //CallModel();
        }

        private void _view_Dividing()
        {
            _view.GetDivide(model.Divide(_view.firstnumber, _view.secondnumber));
        }

        private void _view_Multiplying()
        {
            _view.GetMultiply(model.Multiply(_view.firstnumber, _view.secondnumber));
        }

        private void _view_Minusing()
        {
            _view.GetMinus(model.Minus(_view.firstnumber, _view.secondnumber));
        }
        public void OnSetSum(object sender, EventArgs e)
        {
            _view.GetSum(model.Sum(_view.firstnumber, _view.secondnumber));
        }
    }
}

