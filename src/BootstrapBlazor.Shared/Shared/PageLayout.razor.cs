﻿using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootstrapBlazor.Shared.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PageLayout
    {
        /// <summary>
        ///获得/设置 是否收缩侧边栏
        /// </summary>
        public bool IsCollapsed { get; set; }

        /// <summary>
        /// 获得/设置 是否固定页头
        /// </summary>
        [Parameter]
        public bool FixedHeader { get; set; }

        /// <summary>
        /// 获得/设置 是否固定页脚
        /// </summary>
        [Parameter]
        public bool FixedFooter { get; set; }

        /// <summary>
        /// 获得/设置 侧边栏是否外置
        /// </summary>
        [Parameter]
        public bool IsFullSide { get; set; }

        /// <summary>
        /// 更新组件方法
        /// </summary>
        public void Refresh()
        {
            StateHasChanged();
        }

        private Task OnCollapsed(bool collapsed)
        {
            IsCollapsed = collapsed;
            return Task.CompletedTask;
        }

        private IEnumerable<MenuItem> GetIconSideMenuItems()
        {
            var ret = new List<MenuItem>
            {
                new MenuItem() { Text = "系统设置", IsActive = true, Icon = "fa fa-fw fa-gears" },
                new MenuItem() { Text = "权限设置", Icon = "fa fa-fw fa-users" },
                new MenuItem() { Text = "日志设置", Icon = "fa fa-fw fa-database" }
            };

            ret[0].AddItem(new MenuItem() { Text = "网站设置", Icon = "fa fa-fw fa-fa" });
            ret[0].AddItem(new MenuItem() { Text = "任务设置", Icon = "fa fa-fw fa-tasks" });

            ret[1].AddItem(new MenuItem() { Text = "用户设置", Icon = "fa fa-fw fa-user" });
            ret[1].AddItem(new MenuItem() { Text = "菜单设置", Icon = "fa fa-fw fa-dashboard" });
            ret[1].AddItem(new MenuItem() { Text = "角色设置", Icon = "fa fa-fw fa-sitemap" });

            ret[2].AddItem(new MenuItem() { Text = "访问日志", Icon = "fa fa-fw fa-bars" });
            ret[2].AddItem(new MenuItem() { Text = "登录日志", Icon = "fa fa-fw fa-user-circle-o" });
            ret[2].AddItem(new MenuItem() { Text = "操作日志", Icon = "fa fa-fw fa-edit" });

            return ret;
        }
    }
}
