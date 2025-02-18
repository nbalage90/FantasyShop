import { createSlice } from '@reduxjs/toolkit';

const selectedCategorySlice = createSlice({
  name: 'selectedCategory',
  initialState: {
    selectedCategories: [],
  },
  reducers: {
    setSelectedCategories(state, action) {
      state.selectedCategories = action.payload;
    },
  },
});

export const selectedCategoryActions = selectedCategorySlice.actions;

export default selectedCategorySlice;
