using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DontStarve.Model;
using CCWin;
using DontStarve.IService;
using DontStarve.Service;

namespace DontStarve.App
{
    public partial class F_ShareFood : CCSkinMain
    {
        public F_ShareFood()
        {
            InitializeComponent();
        }
        private ICookieInfoService icookieInfoService = new CookieInfoService();
        private ICategoryInfoService icategoryInfoService = new CategoryInfoService();
        private IMaterialInfoService imaterialInfoService = new MaterialInfoService();

        private void F_ShareFood_Load(object sender, EventArgs e)
        {
            //清空
            clbCategory.Items.Clear();
            //加载分类
            Load_Category();
        }

        /// <summary>
        /// 加载分类
        /// </summary>
        private void Load_Category()
        {
            var list = icategoryInfoService.LoadEntities(ca => true).ToArray();
            //foreach(var l in list)
            //{
            clbCategory.Items.AddRange(list);
            //}
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //检查
            if (string.IsNullOrEmpty(txtFunc.Text) || string.IsNullOrEmpty(txtName.Text) || pic.Image == null || clbCategory.SelectedIndices.Count <= 0 || string.IsNullOrEmpty(txtMaterial.Text))
            {
                MessageBoxEx.Show("请将信息填写完整,谢谢合作");
                return;
            }

            //取值
            cookinfo entity = new cookinfo();
            entity.Guid_id = Guid.NewGuid();
            entity.Name = txtName.Text;
            entity.pic = Common.CommonHelper.PicToBytes(pic.Image);
            entity.Func = txtFunc.Text;
            entity.Remark = txtRemark.Text;
            if (entity.Remark == "备注信息：")
            {
                entity.Remark = "分享人：" + F_Main.current_user.Name + "\n";
            }

            for (int i = 0; i < clbCategory.Items.Count; i++)
            {
                if (clbCategory.GetItemCheckState(i) == CheckState.Checked)
                    entity.categoryinfo.Add(clbCategory.Items[i] as categoryinfo);  //这一步会连接数据库吗？应该不会（<=2ms这么短的时间不会访问数据库）
            }
            //解析原料
            foreach (string line in txtMaterial.Lines)
            {
                string[] details = line.Split('|');
                //根据 details[0] 原料名查询数据库是否存在
                string mName = details[0];
                var material = imaterialInfoService.LoadEntities(m => m.Name == mName).FirstOrDefault();
                //存在，得到原料Id
                if (material != null)
                {
                    entity.r_material_cookinfo.Add(new r_material_cookinfo()
                    {
                        CookId = entity.Guid_id,
                        MaterialId = material.auto_id,
                        Num = details[1]
                    });
                }

                //不存在，插入原料新数据
                else
                {
                    //数据库新插入
                    var entity2 = imaterialInfoService.AddEntityAndReturn(new materialinfo()
                    {
                        Name = details[0],
                        Remark = "提交人：" + F_Main.current_user.Guid_id
                    });
                    
                    entity.r_material_cookinfo.Add(new r_material_cookinfo()
                    {
                        CookId = entity.Guid_id,
                        MaterialId = entity2.auto_id,
                        Num = details[1]
                    });
                }
            }
            //保存到数据库
            if (icookieInfoService.AddEntity(entity))
            {
                MessageBoxEx.Show("提交成功！");
                this.Close();
            }
            else
            {
                MessageBoxEx.Show("提交失败！请重试");
                return;
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片|*.png;*.jpeg;*.jpg;*.ico;*.bmp;*.gif|所有文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromStream(ofd.OpenFile());
            }
        }
    }
}
