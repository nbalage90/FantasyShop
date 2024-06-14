import { createSlice } from '@reduxjs/toolkit';

const loadingStatusSlice = createSlice({
  name: 'loadingStatus',
  initialState: {
    status: 'none',
  },
  reducers: {
    setLoadingStatus(state, action) {
      state.status = action.payload;
      // setTimeout(() => {
      //   state.status = 'none';
      // }, 3000);
    },
  },
});

export const loadingStatusActions = loadingStatusSlice.actions;

export default loadingStatusSlice;
