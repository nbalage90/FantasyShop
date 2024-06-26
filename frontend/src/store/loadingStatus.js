import { createSlice } from '@reduxjs/toolkit';

const loadingStatusSlice = createSlice({
  name: 'loadingStatus',
  initialState: {
    status: 'none',
  },
  reducers: {
    setLoadingStatus(state, action) {
      state.status = action.payload;
    },
  },
});

export const loadingStatusActions = loadingStatusSlice.actions;

export default loadingStatusSlice;
