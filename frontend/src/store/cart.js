import { createSlice } from '@reduxjs/toolkit';

const cartSlice = createSlice({
  name: 'cart',
  initialState: {
    items: [],
    totalQuantity: 0,
    totalPrice: 0,
  },
  reducers: {
    addItem(state, action) {
      const newItem = action.payload;
      const existingItem = state.items.find((item) => item.id === newItem.id);

      if (existingItem) {
        existingItem.count++;
        existingItem.totalPrice += newItem.price;
      } else {
        state.items.push({
          id: newItem.id,
          name: newItem.name,
          category: newItem.category,
          count: 1,
          price: newItem.price,
          totalPrice: newItem.price,
        });
      }

      state.totalQuantity++;
      state.totalPrice += newItem.price;
    },
    removeItem(state, action) {
      const itemId = action.payload;
      const existingItem = state.items.findIndex(itemId);

      if (existingItem.count > 1) {
        existingItem.count--;
        existingItem.totalPrice -= existingItem.price;
      } else {
        // TODO
      }

      state.totalPrice -= existingItem.price;
      state.totalQuantity--;
    },
  },
});

export const cartActions = cartSlice.actions;

export default cartSlice;
