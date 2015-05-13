using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathLabo4
{
    public partial class LoiNormal : Form
    {
        public LoiNormal()
        {
            InitializeComponent();
        }
        public static readonly Double[,] Table = {
{0.0000, 0.0398, 0.0793, 0.1179, 0.1554, 0.1915, 0.2257, 0.2580, 0.2881, 0.3159, 0.3413, 0.3643, 0.3849, 0.4032, 0.4192, 0.4332, 0.4452, 0.4554, 0.4641, 0.4713, 0.4772, 0.4821, 0.4861, 0.4893, 0.4918, 0.4938, 0.4953, 0.4965, 0.4974, 0.4981, 0.4987, 0.4990, 0.4993, 0.4995, 0.4997, 0.4998, 0.4998, 0.4999, 0.4999, 0.5000, 0.5000},
{0.0040, 0.0438, 0.0832, 0.1217, 0.1591, 0.1950, 0.2291, 0.2611, 0.2910, 0.3186, 0.3438, 0.3665, 0.3869, 0.4049, 0.4207, 0.4345, 0.4463, 0.4564, 0.4649, 0.4719, 0.4778, 0.4826, 0.4864, 0.4896, 0.4920, 0.4940, 0.4955, 0.4966, 0.4975, 0.4982, 0.4987, 0.4991, 0.4993, 0.4995, 0.4997, 0.4998, 0.4998, 0.4999, 0.4999, 0.5000, 0.5000},
{0.0080, 0.0478, 0.0871, 0.1255, 0.1628, 0.1985, 0.2324, 0.2642, 0.2939, 0.3212, 0.3461, 0.3686, 0.3888, 0.4066, 0.4222, 0.4357, 0.4474, 0.4573, 0.4656, 0.4726, 0.4783, 0.4830, 0.4868, 0.4898, 0.4922, 0.4941, 0.4956, 0.4967, 0.4976, 0.4982, 0.4987, 0.4991, 0.4994, 0.4995, 0.4997, 0.4998, 0.4999, 0.4999, 0.4999, 0.5000, 0.5000}, 
{0.0120, 0.0517, 0.0910, 0.1293, 0.1664, 0.2019, 0.2357, 0.2673, 0.2967, 0.3238, 0.3485, 0.3708, 0.3907, 0.4082, 0.4236, 0.4370, 0.4484, 0.4582, 0.4664, 0.4732, 0.4788, 0.4834, 0.4871, 0.4901, 0.4925, 0.4943, 0.4957, 0.4968, 0.4977, 0.4983, 0.4988, 0.4991, 0.4994, 0.4996, 0.4997, 0.4998, 0.4999, 0.4999, 0.4999, 0.5000, 0.5000},
{0.0160, 0.0557, 0.0948, 0.1331, 0.1700, 0.2054, 0.2389, 0.2704, 0.2995, 0.3264, 0.3508, 0.3729, 0.3925, 0.4099, 0.4251, 0.4382, 0.4495, 0.4591, 0.4671, 0.4738, 0.4793, 0.4838, 0.4875, 0.4904, 0.4927, 0.4945, 0.4959, 0.4969, 0.4977, 0.4984, 0.4988, 0.4992, 0.4994, 0.4996, 0.4997, 0.4998, 0.4999, 0.4999, 0.4999, 0.5000, 0.5000},
{0.0199, 0.0596, 0.0987, 0.1368, 0.1736, 0.2088, 0.2422, 0.2734, 0.3023, 0.3289, 0.3531, 0.3749, 0.3944, 0.4115, 0.4265, 0.4394, 0.4505, 0.4599, 0.4678, 0.4744, 0.4798, 0.4842, 0.4878, 0.4906, 0.4929, 0.4946, 0.4960, 0.4970, 0.4978, 0.4984, 0.4989, 0.4992, 0.4994, 0.4996, 0.4997, 0.4998, 0.4999, 0.4999, 0.4999, 0.5000, 0.5000},
{0.0239, 0.0636, 0.1026, 0.1406, 0.1772, 0.2123, 0.2454, 0.2764, 0.3051, 0.3315, 0.3554, 0.3770, 0.3962, 0.4131, 0.4279, 0.4406, 0.4515, 0.4608, 0.4686, 0.4750, 0.4803, 0.4846, 0.4881, 0.4909, 0.4931, 0.4948, 0.4961, 0.4971, 0.4979, 0.4985, 0.4989, 0.4992, 0.4994, 0.4996, 0.4997, 0.4998, 0.4999, 0.4999, 0.4999, 0.5000, 0.5000},
{0.0279, 0.0675, 0.1064, 0.1443, 0.1808, 0.2157, 0.2486, 0.2794, 0.3078, 0.3340, 0.3577, 0.3790, 0.3980, 0.4147, 0.4292, 0.4418, 0.4525, 0.4616, 0.4693, 0.4756, 0.4808, 0.4850, 0.4884, 0.4911, 0.4932, 0.4949, 0.4962, 0.4972, 0.4979, 0.4985, 0.4989, 0.4992, 0.4995, 0.4996, 0.4997, 0.4998, 0.4999, 0.4999, 0.4999, 0.5000, 0.5000},
{0.0319, 0.0714, 0.1103, 0.1480, 0.1844, 0.2190, 0.2517, 0.2823, 0.3106, 0.3365, 0.3599, 0.3810, 0.3997, 0.4162, 0.4306, 0.4429, 0.4535, 0.4625, 0.4699, 0.4761, 0.4812, 0.4854, 0.4887, 0.4913, 0.4934, 0.4951, 0.4963, 0.4973, 0.4980, 0.4986, 0.4990, 0.4993, 0.4995, 0.4996, 0.4997, 0.4998, 0.4999, 0.4999, 0.4999, 0.5000, 0.5000},
{0.0359, 0.0753, 0.1141, 0.1517, 0.1879, 0.2224, 0.2549, 0.2852, 0.3133, 0.3389, 0.3621, 0.3830, 0.4015, 0.4177, 0.4319, 0.4441, 0.4545, 0.4633, 0.4706, 0.4767, 0.4817, 0.4857, 0.4890, 0.4916, 0.4936, 0.4952, 0.4964, 0.4974, 0.4981, 0.4986, 0.4990, 0.4993, 0.4995, 0.4997, 0.4998, 0.4998, 0.4999, 0.4999, 0.4999, 0.5000, 0.5000}
};
        // Variable pour chaque champs de text
        public double moyenne;
        public double écartType;

        public double cas1VarA;
        public double cas1VarB;
        public double cas1Resultat;

        public double cas2VarA;
        public double cas2Resultat;

        public double cas3VarA;
        public double cas3Resultat;


        // P( ? < Z < ? )
        private void TBN_Cas1_Click(object sender, EventArgs e)
        {
            // Initialisation importante pour le fonctionnement du programme
            cas1Resultat = 0;
            VérifierXetO();
            
            double varA_Z;
            double varB_Z;
            double tempA;
            double tempB;

            // Mettre la valeur des textbox dans les variables
            cas1VarA = System.Double.Parse(TBX_Cas1_VarA.Text, System.Globalization.NumberStyles.AllowDecimalPoint | NumberStyles.AllowTrailingSign, System.Globalization.NumberFormatInfo.InvariantInfo);
            cas1VarB = System.Double.Parse(TBX_Cas1_VarB.Text, System.Globalization.NumberStyles.AllowDecimalPoint | NumberStyles.AllowTrailingSign, System.Globalization.NumberFormatInfo.InvariantInfo);

            // Calculer la code Z pour chaque valeur
            varA_Z = (cas1VarA - moyenne) / écartType;
            varB_Z = (cas1VarB - moyenne) / écartType;

            // Les arrondirs
            varA_Z = Math.Round(varA_Z, 2);
            varB_Z = Math.Round(varB_Z, 2);

            // Rendre les cotes Z positives.
            if(varA_Z < 0)
            {
                varA_Z = varA_Z * -1;
            }
            if (varB_Z < 0)
            {
                varB_Z = varB_Z * -1;
            }

            // Trouver le pourcentage de probabiliter avec chaque cote Z           
            tempA = TrouverCoteZDansTable(varA_Z);// Sa retourne la P( 0 < Z < varA_Z )
            tempB = TrouverCoteZDansTable(varB_Z);// P( 0 < Z < varB_Z )

            // Toutes les conditions pour le fonctionnement de la loi normale
            if ((cas1VarA > moyenne && cas1VarB > moyenne) || 
                (cas1VarA < moyenne && cas1VarB < moyenne))
                cas1Resultat = tempB - tempA;
            else
                cas1Resultat = tempA + tempB;

            // Écrire le résultat dans le bon TextBox
            TBX_Cas1_Resultat.Text = cas1Resultat.ToString();
        }
        private void VérifierXetO()
        {
            moyenne = System.Double.Parse(TBX_Moyenne.Text, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
            écartType = System.Double.Parse(TBX_ÉcartType.Text,System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
        }
        private double TrouverCoteZDansTable(double z)
        {
            int Valeur1;
            int Valeur2;
            String sZ = z.ToString();
            if(sZ.Length != 4)
                Valeur1 = 0;
            else
                Valeur1 = System.Int32.Parse(sZ.Substring(3));

            Valeur2 = (int)(z * 10);


            return Table[Valeur1, Valeur2];
            /*if (cas1VarA > moyenne && cas1VarB > moyenne)
            cas1Resultat += Table[Valeur1, Valeur2];
            cas2Resultat += Table[Valeur1, Valeur2];
            if(cas3VarA > moyenne)
                cas3Resultat -= Table[Valeur1, Valeur2];
            else
                cas3Resultat += Table[Valeur1, Valeur2];*/
        }

        // P( X < ? )
        private void BTN_Cas2_Click(object sender, EventArgs e)
        {
            // Initialisation importante pour le fonctionnement du programme
            cas2Resultat = 0;
            VérifierXetO();
           
            double varA_Z;
            double tempA;

            // Mettre la valeur des textbox dans les variables
            cas2VarA = System.Double.Parse(TBX_Cas2_VarA.Text, System.Globalization.NumberStyles.AllowDecimalPoint | NumberStyles.AllowTrailingSign, System.Globalization.NumberFormatInfo.InvariantInfo);

            // Calculer la code Z pour chaque valeur
            varA_Z = (cas2VarA - moyenne) / écartType;

            // Les arrondirs
            varA_Z = Math.Round(varA_Z, 2);

            // Rendre les cotes Z positives.
            if (varA_Z < 0)
            {
                varA_Z = varA_Z * -1;

                // Trouver le pourcentage de probabiliter avec chaque cote Z  
                tempA = TrouverCoteZDansTable(varA_Z);

                if (cas2VarA > moyenne)
                    cas2Resultat = 0.5 - tempA;
                else
                    cas2Resultat = 0.5 + tempA;
            }
            else
            {
                // Trouver le pourcentage de probabiliter avec chaque cote Z  
                tempA = TrouverCoteZDansTable(varA_Z);

                if(cas3VarA < moyenne)
                    cas2Resultat = 0.5 - tempA;
                else
                    cas2Resultat = tempA + 0.5;
            }

            // Écrire le résultat dans le bon TextBox
            TBX_Cas2_Resultat.Text = cas2Resultat.ToString();
        }

        // P( X > ? )
        private void BTN_Cas3_Click(object sender, EventArgs e)
        {
            // Initialisation importante pour le fonctionnement du programme
            cas3Resultat = 0;
            VérifierXetO();
            
            double varA_Z;
            double tempA;

            // Mettre la valeur des textbox dans les variables
            cas3VarA = System.Double.Parse(TBX_Cas3_VarA.Text, System.Globalization.NumberStyles.AllowDecimalPoint | NumberStyles.AllowTrailingSign, System.Globalization.NumberFormatInfo.InvariantInfo);

            // Calculer la code Z pour chaque valeur
            varA_Z = (cas3VarA - moyenne) / écartType;

            // Les arrondirs
            varA_Z = Math.Round(varA_Z, 2);

            // Rendre les cotes Z positives.
            if (varA_Z < 0)
            {
                varA_Z = varA_Z * -1;
            }

            // Trouver le pourcentage de probabiliter avec chaque cote Z  
            tempA = TrouverCoteZDansTable(varA_Z);

            if (cas3VarA > moyenne)
                cas3Resultat = 0.5 - tempA;
            else
                cas3Resultat = 0.5 + tempA;

            // Écrire le résultat dans le bon TextBox
            TBX_Cas3_Resultat.Text = cas3Resultat.ToString();
        }
    }

} 

