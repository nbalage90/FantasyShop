import { NavLink } from 'react-router-dom';
import { useSelector } from 'react-redux';

import classes from './Header.module.css';
import { useEffect, useState } from 'react';

import './Header.css';

export default function Header() {
  const [loadingStatus, setLoadingStatus] = useState('none');
  const status = useSelector((state) => state.loadingStatus.status);

  useEffect(() => {
    setLoadingStatus(status);
  }, [status]);

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
          <NavLink>Cart(0)</NavLink>
        </li>
      </nav>
    </header>
  );
}
