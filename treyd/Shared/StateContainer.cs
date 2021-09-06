using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using treyd.Models;

namespace treyd
{
    internal class StateContainer
    {
        public event Action OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();

        // CATEGORY RELATED //
        public string ViewMode { get; set; }
        public SortMethod SortMethod { get; set; }
        public List<CategoryModel> CategoryList { get; set; }
        public CategoryModel Category { get; set; }
        public double[] PriceRange { get; set; }
        public bool? InStock { get; set; }
        public bool ShowShoppingSidebar { get; set; }

        public void ClearFilters()
        {
            this.SortMethod = null;
            this.InStock = null;
            this.PriceRange = new double[] { 0, 50000 };
            this.Category = null;
            this.CategoryList = null;

            NotifyStateChanged();
        }

        public async Task GetShoppingSidebarState(bool showShoppingSidebar)
        {
            this.ShowShoppingSidebar = showShoppingSidebar;
            NotifyStateChanged();
        }

        public void GetViewModeState(string viewMode)
        {
            this.ViewMode = viewMode;
            NotifyStateChanged();
        }

        public void GetCategoryState(List<CategoryModel> categories, CategoryModel category)
        {
            if (categories != null && categories.Count != 0)
            {
                this.CategoryList = categories;
            }
            if (category != null)
            {
                this.Category = category;
            }

            NotifyStateChanged();
        }

        public void GetSortingMethodState(SortMethod sortMethod)
        {
            this.SortMethod = sortMethod;
            NotifyStateChanged();
        }

        public void GetPriceRangeState(double[] priceRange)
        {
            this.PriceRange = priceRange;
            NotifyStateChanged();
        }

        public void GetInStockState(bool inStock)
        {
            this.InStock = inStock;
            NotifyStateChanged();
        }

        // AUTHENTICATION RELATED //
        public bool IsLoggedIn { get; set; }
        public bool IsLoggedOut { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsDeleted { get; set; }

        public void SetIsLoggedIn(bool IsLoggedIn)
        {
            this.IsLoggedIn = IsLoggedIn;
            NotifyStateChanged();
        }

        public void SetIsLoggedOut(bool IsLoggedOut)
        {
            this.IsLoggedOut = IsLoggedOut;
            NotifyStateChanged();
        }

        public void SetIsRegistered(bool IsRegistered)
        {
            this.IsRegistered = IsRegistered;
            NotifyStateChanged();
        }

        public void SetIsDeleted(bool IsDeleted)
        {
            this.IsDeleted = IsDeleted;
            NotifyStateChanged();
        }

        public bool GetIsLoggedIn()
        {
            return IsLoggedIn;
        }

        public bool GetIsLoggedOut()
        {
            return IsLoggedOut;
        }

        public bool GetIsRegistered()
        {
            return IsRegistered;
        }

        public bool GetIsDeleted()
        {
            return IsDeleted;
        }
    }
}
