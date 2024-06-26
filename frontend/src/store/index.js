import { configureStore } from '@reduxjs/toolkit';
import loadingStatusSlice from './loadingStatus';
import cartSlice from './cart';
import uiSlice from './ui';

const store = configureStore({
  reducer: {
    loadingStatus: loadingStatusSlice.reducer,
    cart: cartSlice.reducer,
    ui: uiSlice.reducer,
  },
});

export default store;
