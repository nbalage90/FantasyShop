import { configureStore } from '@reduxjs/toolkit';
import loadingStatus from './loadingStatus';

const store = configureStore({
  reducer: {
    loadingStatus: loadingStatus.reducer,
  },
});

export default store;
