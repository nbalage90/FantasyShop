import { useEffect, useState } from 'react';
import { NavLink } from 'react-router-dom';
import { useDispatch, useSelector } from 'react-redux';

import classes from './Header.module.css';

import { uiActions } from '../../store/ui';

import './Header.css';

const PENDING_NOTIFICATION_TIME = 10000;
const ERROR_NOTIFICATION_TIME = 3000;
const SUCCESS_NOTIFICATION_TIME = 1000;

export default function Header() {
  const [loadingStatus, setLoadingStatus] = useState('none');
  const status = useSelector((state) => state.loadingStatus.status);
  const cartQuantity = useSelector((state) => state.cart.totalQuantity);
  const dispatch = useDispatch();

  useEffect(() => {
    if (status && status !== 'none') {
      setLoadingStatus(status);

      let timeout;

      if (status === 'success') {
        timeout = SUCCESS_NOTIFICATION_TIME;
      } else if (status === 'pending') {
        timeout = PENDING_NOTIFICATION_TIME;
      } else {
        timeout = ERROR_NOTIFICATION_TIME;
      }

      setTimeout(() => {
        setLoadingStatus('none');
      }, timeout);
    }
  }, [status]);

  function handleCartButtonClick() {
    dispatch(uiActions.openCart());
  }

  return (
    <header className={classes.header}>
      <div className={`${classes.loadingbar} ${loadingStatus}`}></div>
      <nav>
        <li>
          <NavLink
            to="/"
            className={({ isActive }) => (isActive ? 'active' : undefined)}
            end
          >
            Home
          </NavLink>
        </li>
        <li>
          <NavLink
            to="/products"
            className={({ isActive }) => (isActive ? 'active' : undefined)}
          >
            Products
          </NavLink>
        </li>
        <li>
          <NavLink onClick={handleCartButtonClick}>
            Cart({cartQuantity})
          </NavLink>
        </li>
      </nav>
    </header>
  );
}
