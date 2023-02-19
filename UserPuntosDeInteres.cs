using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_definitivo
{
    public partial class UserPuntosDeInteres : UserControl
    {
        public Form1 form { set; get; }
        public UserPuntosDeInteres()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/search?q=churros+4+esquinas+albaycin&rlz=1C1CHBF_esES1017ES1017&biw=1920&bih=969&tbm=lcl&ei=7RXwY5jqHpOCkdUPlduIkA4&ved=0ahUKEwjYlN3U4p39AhUTQaQEHZUtAuIQ4dUDCAk&uact=5&oq=churros+4+esquinas+albaycin&gs_lcp=Cg1nd3Mtd2l6LWxvY2FsEAMyBwghEKABEAoyBwghEKABEAo6BQghEKABOgQIIRAVOgsIIRAWEB4Q8QQQHVCOBViCGGCpG2gAcAB4AIABeYgBhQmSAQQwLjEwmAEAoAEBwAEB&sclient=gws-wiz-local#rlfi=hd:;si:16739863156009971319,l,ChtjaHVycm9zIDQgZXNxdWluYXMgYWxiYXljaW5IsrPYioStgIAIWisQABgBGAIYAyIbY2h1cnJvcyA0IGVzcXVpbmFzIGFsYmF5Y2luKgQIAxAAkgEEY2FmZZoBI0NoWkRTVWhOTUc5blMwVkpRMEZuU1VOVlgyUlFRbEJuRUFF,y,O7fAD2Y-4rA;mv:[[37.2057779,-3.5914797999999992],[37.1592365,-3.6150439]]");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/search?q=Casa+pasteles+albayzin&rlz=1C1CHBF_esES1017ES1017&tbm=lcl&ei=xhPwY_TOPKOPkdUP4-u7sAs&ved=0ahUKEwj0yZzO4J39AhWjR6QEHeP1DrYQ4dUDCAk&uact=5&oq=Casa+pasteles+albayzin&gs_lcp=Cg1nd3Mtd2l6LWxvY2FsEAMyBQgAEIAEMgIIJjoECAAQQzoICAAQsQMQgwE6CAgAEIAEELEDOgsIABCABBCxAxCDAToLCAAQgAQQsQMQyQM6BQgAEJIDOg4IABCABBCxAxCDARDJAzoICAAQgAQQkgM6BggAEBYQHjoJCAAQFhAeEPEEOgcIABCABBATUOEQWOoxYN40aABwAHgAgAFTiAHeDJIBAjI0mAEAoAEBwAEB&sclient=gws-wiz-local");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/search?q=locutorio+murallas+del+abaicin&rlz=1C1CHBF_esES1017ES1017&tbm=lcl&ei=xhPwY_TOPKOPkdUP4-u7sAs&ved=0ahUKEwj0yZzO4J39AhWjR6QEHeP1DrYQ4dUDCAk&uact=5&oq=locutorio+murallas+del+abaicin&gs_lcp=Cg1nd3Mtd2l6LWxvY2FsEAMyBwghEKABEAoyBwghEKABEAoyBwghEKABEAoyBwghEKABEAo6BAgAEEM6CwgAEIAEELEDEIMBOggIABCABBCxAzoFCAAQgAQ6CwgAEIAEELEDEMkDOgUIABCSAzoICAAQgAQQkgM6CggAEIAEELEDEAo6DQgAEIAEELEDEMkDEAo6CggAEIAEEJIDEAo6BwgAEIAEEAo6DQgAEIAEELEDEIMBEAo6CQgAEBYQHhDxBDoGCAAQFhAeOgIIJjoFCCEQoAFQAFjBSmD2TWgBcAB4AIABfogBiBmSAQUxNC4xN5gBAKABAcABAQ&sclient=gws-wiz-local");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/search?q=churros+4+esquinas+albaycin&rlz=1C1CHBF_esES1017ES1017&biw=1920&bih=969&tbm=lcl&ei=7RXwY5jqHpOCkdUPlduIkA4&ved=0ahUKEwjYlN3U4p39AhUTQaQEHZUtAuIQ4dUDCAk&uact=5&oq=churros+4+esquinas+albaycin&gs_lcp=Cg1nd3Mtd2l6LWxvY2FsEAMyBwghEKABEAoyBwghEKABEAo6BQghEKABOgQIIRAVOgsIIRAWEB4Q8QQQHVCOBViCGGCpG2gAcAB4AIABeYgBhQmSAQQwLjEwmAEAoAEBwAEB&sclient=gws-wiz-local#rlfi=hd:;si:16739863156009971319,l,ChtjaHVycm9zIDQgZXNxdWluYXMgYWxiYXljaW5IsrPYioStgIAIWisQABgBGAIYAyIbY2h1cnJvcyA0IGVzcXVpbmFzIGFsYmF5Y2luKgQIAxAAkgEEY2FmZZoBI0NoWkRTVWhOTUc5blMwVkpRMEZuU1VOVlgyUlFRbEJuRUFF,y,O7fAD2Y-4rA;mv:[[37.2057779,-3.5914797999999992],[37.1592365,-3.6150439]]");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/search?q=churros+4+esquinas+albaycin&rlz=1C1CHBF_esES1017ES1017&biw=1920&bih=969&tbm=lcl&ei=7RXwY5jqHpOCkdUPlduIkA4&ved=0ahUKEwjYlN3U4p39AhUTQaQEHZUtAuIQ4dUDCAk&uact=5&oq=churros+4+esquinas+albaycin&gs_lcp=Cg1nd3Mtd2l6LWxvY2FsEAMyBwghEKABEAoyBwghEKABEAo6BQghEKABOgQIIRAVOgsIIRAWEB4Q8QQQHVCOBViCGGCpG2gAcAB4AIABeYgBhQmSAQQwLjEwmAEAoAEBwAEB&sclient=gws-wiz-local#rlfi=hd:;si:16739863156009971319,l,ChtjaHVycm9zIDQgZXNxdWluYXMgYWxiYXljaW5IsrPYioStgIAIWisQABgBGAIYAyIbY2h1cnJvcyA0IGVzcXVpbmFzIGFsYmF5Y2luKgQIAxAAkgEEY2FmZZoBI0NoWkRTVWhOTUc5blMwVkpRMEZuU1VOVlgyUlFRbEJuRUFF,y,O7fAD2Y-4rA;mv:[[37.2057779,-3.5914797999999992],[37.1592365,-3.6150439]]");
        }


        private void btback_Click(object sender, EventArgs e)
        {
            form.MostrarUserAlumno1();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel6.LinkVisited= true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Alimentaci%C3%B3n+Los+Dos/@37.1841676,-3.5936542,21z/data=!4m13!1m7!3m6!1s0xd71fcc5c290f3a5:0x2cf3e8c37b70738a!2sCalle+San+Gregorio+Alto,+18010+Granada!3b1!8m2!3d37.1847637!4d-3.5925881!3m4!1s0xd71fd4c78319831:0xba3184a28ddc6990!8m2!3d37.1841735!4d-3.5937631?hl=es");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel5.LinkVisited= true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Elemen/@37.1837816,-3.5931885,20.44z/data=!4m13!1m7!3m6!1s0xd71fcc5c290f3a5:0x2cf3e8c37b70738a!2sCalle+San+Gregorio+Alto,+18010+Granada!3b1!8m2!3d37.1847637!4d-3.5925881!3m4!1s0xd71fd234994f0ff:0xb59b8e2ffa21ff53!8m2!3d37.1836021!4d-3.5927783?hl=es");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel4.LinkVisited= true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Alimentacion+y+Bebidas+Alquibla/@37.183826,-3.59318,20.19z/data=!4m13!1m7!3m6!1s0xd71fcc5c290f3a5:0x2cf3e8c37b70738a!2sCalle+San+Gregorio+Alto,+18010+Granada!3b1!8m2!3d37.1847637!4d-3.5925881!3m4!1s0xd71fcc674374ea3:0xc595dca02f63fe0b!8m2!3d37.1838412!4d-3.5928355?hl=es");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.MiradorSanNicolas.LinkVisited= true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/C.+Mirador+de+San+Nicol%C3%A1s,+18010+Granada/@37.1812166,-3.5946554,17z/data=!3m1!4b1!4m5!3m4!1s0xd71fcc7c961238b:0xe0cb79755e1ffe96!8m2!3d37.1812123!4d-3.5924667?hl=es");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.MiradorSanCristobal.LinkVisited= true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Pl.+Mirador+de+San+Crist%C3%B3bal,+18010+Granada/@37.1829817,-3.5980688,17z/data=!3m1!4b1!4m5!3m4!1s0xd71fcc6b11008b1:0xece7aa587e20f90d!8m2!3d37.1829774!4d-3.5958801?hl=es");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.MiradorSanCristobal.LinkVisited= true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Pl.+Mirador+de+San+Crist%C3%B3bal,+18010+Granada/@37.1829817,-3.5980688,17z/data=!3m1!4b1!4m5!3m4!1s0xd71fcc6b11008b1:0xece7aa587e20f90d!8m2!3d37.1829774!4d-3.5958801?hl=es");
        }

       

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel7.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Pl.+Larga,+18010+Granada/@37.182726,-3.5956565,17z/data=!3m1!4b1!4m5!3m4!1s0xd71fcc65d569015:0xeb97399e65b3e195!8m2!3d37.1827217!4d-3.5934678?hl=es");
        }
    

        private void button9_Click(object sender, EventArgs e)
        {
            this.linkLabel7.LinkVisited= true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Pl.+Larga,+18010+Granada/@37.182726,-3.5956565,17z/data=!3m1!4b1!4m5!3m4!1s0xd71fcc65d569015:0xeb97399e65b3e195!8m2!3d37.1827217!4d-3.5934678?hl=es");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/search?q=Casa+pasteles+albayzin&rlz=1C1CHBF_esES1017ES1017&tbm=lcl&ei=xhPwY_TOPKOPkdUP4-u7sAs&ved=0ahUKEwj0yZzO4J39AhWjR6QEHeP1DrYQ4dUDCAk&uact=5&oq=Casa+pasteles+albayzin&gs_lcp=Cg1nd3Mtd2l6LWxvY2FsEAMyBQgAEIAEMgIIJjoECAAQQzoICAAQsQMQgwE6CAgAEIAEELEDOgsIABCABBCxAxCDAToLCAAQgAQQsQMQyQM6BQgAEJIDOg4IABCABBCxAxCDARDJAzoICAAQgAQQkgM6BggAEBYQHjoJCAAQFhAeEPEEOgcIABCABBATUOEQWOoxYN40aABwAHgAgAFTiAHeDJIBAjI0mAEAoAEBwAEB&sclient=gws-wiz-local");
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.linkLabel6.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Alimentaci%C3%B3n+Los+Dos/@37.1841676,-3.5936542,21z/data=!4m13!1m7!3m6!1s0xd71fcc5c290f3a5:0x2cf3e8c37b70738a!2sCalle+San+Gregorio+Alto,+18010+Granada!3b1!8m2!3d37.1847637!4d-3.5925881!3m4!1s0xd71fd4c78319831:0xba3184a28ddc6990!8m2!3d37.1841735!4d-3.5937631?hl=es");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.linkLabel5.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Elemen/@37.1837816,-3.5931885,20.44z/data=!4m13!1m7!3m6!1s0xd71fcc5c290f3a5:0x2cf3e8c37b70738a!2sCalle+San+Gregorio+Alto,+18010+Granada!3b1!8m2!3d37.1847637!4d-3.5925881!3m4!1s0xd71fd234994f0ff:0xb59b8e2ffa21ff53!8m2!3d37.1836021!4d-3.5927783?hl=es");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Alimentacion+y+Bebidas+Alquibla/@37.183826,-3.59318,20.19z/data=!4m13!1m7!3m6!1s0xd71fcc5c290f3a5:0x2cf3e8c37b70738a!2sCalle+San+Gregorio+Alto,+18010+Granada!3b1!8m2!3d37.1847637!4d-3.5925881!3m4!1s0xd71fcc674374ea3:0xc595dca02f63fe0b!8m2!3d37.1838412!4d-3.5928355?hl=es");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.MiradorSanNicolas.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/C.+Mirador+de+San+Nicol%C3%A1s,+18010+Granada/@37.1812166,-3.5946554,17z/data=!3m1!4b1!4m5!3m4!1s0xd71fcc7c961238b:0xe0cb79755e1ffe96!8m2!3d37.1812123!4d-3.5924667?hl=es");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form.MostrarUserAlumno1();
            
        }
    }
}
