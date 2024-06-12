import { NavLink } from 'react-router-dom';
import classes from './Header.module.css';

export default function Header() {
  return (
    <header className={classes.header}>
      <nav>
        <li>
          <NavLink
            to="/"
            className={(isActive) => (isActive ? 'active' : undefined)}
            end
          >
            Home
          </NavLink>
        </li>
        <li>
          <NavLink
            to="products"
            className={(isActive) => (isActive ? 'active' : undefined)}
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
