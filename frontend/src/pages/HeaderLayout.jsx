import { Outlet } from 'react-router';
import Header from '../components/Header/Header';
import Cart from '../components/Cart/Cart';

export default function HeaderLayout() {
  return (
    <>
      <Cart />
      <Header />
      <main>
        <Outlet />
      </main>
    </>
  );
}
