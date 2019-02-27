using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NormalWpfApp
{
   
    public partial class Planetary : Window
    {
        public Planetary()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            if(rusckpl.IsChecked == false)
            {
                backbpl.Content = "Back";
                coolerb.Content = "Cooler Version";
                pltextlb.Content = "Information";
                listpllb.Content = "Planet list";
                Mer.Content = "Mercury";
                Sat.Content = "Saturn";
                Ven.Content = "Venus";
                Earth.Content = "Earth";
                Mars.Content = "Mars";
                Jup.Content = "Jupiter";
                Anus.Content = "Uranus";
                Nep.Content = "Neptune";
                Pluto.Content = "Pluto";
            }
        }

        private void Mer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (rusckpl.IsChecked == true)
            {
                pltext.Text = "Мерку́рий — ближайшая к Солнцу планета Солнечной системы[12], наименьшая из планет земной группы. Названа в честь древнеримского бога торговли — быстрого Меркурия, поскольку она движется по небесной сфере быстрее других планет.";
            }
            else
            {
                pltext.Text = "Mercury is the smallest and innermost planet in the Solar System. Its orbital period around the Sun of 87.97 days is the shortest of all the planets in the Solar System. It is named after the Roman deity Mercury, the messenger of the gods.";
            }
        }

        
        private void Backbpl_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ven_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (rusckpl.IsChecked == true)
            {
                pltext.Text = "Вене́ра — вторая по удалённости от Солнца планета Солнечной системы, наряду с Меркурием, Землёй и Марсом принадлежит к семейству планет земной группы. Названа в честь древнеримской богини любви Венеры[6]. Венерианский год составляет 224,7 земных суток. Она имеет самый длинный период вращения вокруг своей оси (243 земных суток) среди всех планет Солнечной системы и вращается в направлении, противоположном направлению вращения большинства планет. Венера не имеет естественных спутников. Это третий по яркости объект на небе Земли, после Солнца и Луны. Планета достигает видимой звёздной величины −4,6m — так что её яркости достаточно, чтобы отбрасывать тени ночью. Изредка Венера видна невооружённым глазом и в светлое время суток.";
            }
            else
            {
                pltext.Text = "Venus is the second planet from the Sun, orbiting it every 224.7 Earth days. It has the longest rotation period (243 days) of any planet in the Solar System and rotates in the opposite direction to most other planets (meaning the Sun rises in the west and sets in the east). It does not have any natural satellites. It is named after the Roman goddess of love and beauty. It is the second-brightest natural object in the night sky after the Moon, reaching an apparent magnitude of −4.6 – bright enough to cast shadows at night and, rarely, visible to the naked eye in broad daylight. Orbiting within Earth's orbit, Venus is an inferior planet and never appears to venture far from the Sun; its maximum angular distance from the Sun (elongation) is 47.8°.";
            }
        }

        private void Earth_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (rusckpl.IsChecked == true)
            {
                pltext.Text = "Земля́ — третья по удалённости от Солнца планета Солнечной системы. Самая плотная, пятая по диаметру и массе среди всех планет и крупнейшая среди планет земной группы, в которую входят также Меркурий, Венера и Марс. Иногда упоминается как Мир, Голубая планета[17][18][19], иногда Терра (от лат. Terra). Единственное известное человеку на данный момент тело Солнечной системы в частности и Вселенной вообще, населённое живыми организмами.";

            }
            else
            {
                pltext.Text = "Earth is the third planet from the Sun and the only astronomical object known to harbor life. According to radiometric dating and other sources of evidence, Earth formed over 4.5 billion years ago. Earth's gravity interacts with other objects in space, especially the Sun and the Moon, Earth's only natural satellite. Earth revolves around the Sun in 365.26 days, a period known as an Earth year. During this time, Earth rotates about its axis about 366.26 times.";
            }
        }

        private void Mars_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (rusckpl.IsChecked == true)
            {
                pltext.Text = "Марс — четвёртая по удалённости от Солнца и седьмая по размерам планета Солнечной системы; масса планеты составляет 10,7 % массы Земли. Названа в честь Марса — древнеримского бога войны, соответствующего древнегреческому Аресу. Иногда Марс называют «красной планетой» из-за красноватого оттенка поверхности, придаваемого ей минералом маггемитом — γ-оксидом железа(III).";
            }
            else
            {
                pltext.Text = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System after Mercury. In English, Mars carries a name of the Roman god of war, and is often referred to as the Red Planet because the reddish iron oxide prevalent on its surface gives it a reddish appearance that is distinctive among the astronomical bodies visible to the naked eye. Mars is a terrestrial planet with a thin atmosphere, having surface features reminiscent both of the impact craters of the Moon and the valleys, deserts, and polar ice caps of Earth.";
            }
        }

        private void Jup_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (rusckpl.IsChecked == true)
            {
                pltext.Text = "Юпи́тер — крупнейшая планета Солнечной системы, пятая по удалённости от Солнца. Наряду с Сатурном, Ураном и Нептуном, Юпитер классифицируется как газовый гигант. Планета была известна людям с глубокой древности, что нашло своё отражение в мифологии и религиозных верованиях различных культур: месопотамской, вавилонской, греческой и других.Современное название Юпитера происходит от имени древнеримского верховного бога - громовержца.";
            }
            else
            {
                pltext.Text = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a giant planet with a mass one-thousandth that of the Sun, but two-and-a-half times that of all the other planets in the Solar System combined. Jupiter and Saturn are gas giants; the other two giant planets, Uranus and Neptune, are ice giants. Jupiter has been known to astronomers since antiquity. It is named after the Roman god Jupiter. When viewed from Earth, Jupiter can reach an apparent magnitude of −2.94, bright enough for its reflected light to cast shadows, and making it on average the third-brightest natural object in the night sky after the Moon and Venus.";
            }
        }

        private void Sat_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (rusckpl.IsChecked == true)
            {
                pltext.Text = "Сату́рн — шестая планета от Солнца и вторая по размерам планета в Солнечной системе после Юпитера. Сатурн, а также Юпитер, Уран и Нептун, классифицируются как газовые гиганты. Сатурн назван в честь римского бога земледелия. Символ Сатурна — серп (Юникод: ♄).";
            }
            else
            {
                pltext.Text = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. It is a gas giant with an average radius about nine times that of Earth. It has only one-eighth the average density of Earth, but with its larger volume Saturn is over 95 times more massive. Saturn is named after the Roman god of agriculture; its astronomical symbol (♄) represents the god's sickle.";
            }
        }

        private void Anus_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (rusckpl.IsChecked == true)
            {
                pltext.Text = "Ура́н — планета Солнечной системы, седьмая по удалённости от Солнца, третья по диаметру и четвёртая по массе. Была открыта в 1781 году английским астрономом Уильямом Гершелем и названа в честь греческого бога неба Урана. Уран стал первой планетой, обнаруженной в Новое время и при помощи телескопа[12].Его открыл Уильям Гершель 13 марта 1781 года[13], тем самым впервые со времён античности расширив границы Солнечной системы в глазах человека.Несмотря на то, что порой Уран различим невооружённым глазом, более ранние наблюдатели принимали его за тусклую звезду";
            }
            else
            {
                pltext.Text = "Uranus (from the Latin name Uranus for the Greek god Οὐρανός) is the seventh planet from the Sun. It has the third-largest planetary radius and fourth-largest planetary mass in the Solar System. Uranus is similar in composition to Neptune, and both have bulk chemical compositions which differ from that of the larger gas giants Jupiter and Saturn. For this reason, scientists often classify Uranus and Neptune as ice giants to distinguish them from the gas giants. Uranus' atmosphere is similar to Jupiter's and Saturn's in its primary composition of hydrogen and helium, but it contains more isec such as water, ammonia, and methane, along with traces of other hydrocarbons.";
            }
        }

        private void Nep_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (rusckpl.IsChecked == true)
            {
                pltext.Text = "Непту́н — восьмая и самая дальняя от Земли планета Солнечной системы. Нептун также является четвёртой по диаметру и третьей по массе планетой. Масса Нептуна в 17,2 раза, а диаметр экватора в 3,9 раза больше земных[10]. Планета была названа в честь римского бога морей. Её астрономический символ Neptune symbol.svg — стилизованная версия трезубца Нептуна.";

            }
            else
            {
                pltext.Text = "Neptune is the eighth and farthest known planet from the Sun in the Solar System. In the Solar System, it is the fourth-largest planet by diameter, the third-most-massive planet, and the densest giant planet. Neptune is 17 times the mass of Earth and is slightly more massive than its near-twin Uranus, which is 15 times the mass of Earth and slightly larger than Neptune. Neptune orbits the Sun once every 164.8 years at an average distance of 30.1 AU (4.5 billion km). It is named after the Roman god of the sea and has the astronomical symbol ♆, a stylised version of the god Neptune's trident.";
            }
        }

        private void Pluto_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (rusckpl.IsChecked == true)
            {
                pltext.Text = "Плуто́н (134340 Pluto) — карликовая планета Солнечной системы[9], транснептуновый объект и десятое по массе (без учёта спутников) небесное тело, обращающееся вокруг Солнца — после восьми планет и Эриды[10][11][12]. Первоначально Плутон считали планетой, но сейчас он считается карликовой планетой и крупнейшим объектом пояса Койпера[9].";
            }
            else
            {
                pltext.Text = "Pluto (minor planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt, a ring of bodies beyond Neptune. It was the first Kuiper belt object to be discovered and is the largest known plutoid (or ice dwarf).";
            }
        }

        private void Rusckpl_Checked(object sender, RoutedEventArgs e)
        {
            if(rusckpl.IsChecked == true)
            {
                backbpl.Content = "Назад";
                coolerb.Content = "Крутая Версия";
                pltextlb.Content = "Информация";
                listpllb.Content = "Список Планет";
                Mer.Content = "Меркурий";
                Sat.Content = "Сатурн";
                Ven.Content = "Венера";
                Earth.Content = "Земля";
                Mars.Content = "Марс";
                Jup.Content = "Юпитер";
                Anus.Content = "Уран";
                Nep.Content = "Нептун";
                Pluto.Content = "Плутон";
            }
        }

        private void Coolerb_MouseEnter(object sender, MouseEventArgs e)
        {
            if (rusckpl.IsChecked == true)
                Anonce.Content = "Скоро будет доступно";
            else
            {
                Anonce.Content = "Will be availeble soon";
            }
        }

        private void Coolerb_MouseLeave(object sender, MouseEventArgs e)
        {
            Anonce.Content = null;
        }

        private void Backbpl_MouseEnter(object sender, MouseEventArgs e)
        {
            backbpl.Foreground = Brushes.White;
            
        }

        private void Backbpl_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            
            backbpl.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }
    }
}
