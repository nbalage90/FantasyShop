import { Outlet } from 'react-router';
import Header from '../components/Header/Header';

export default function HeaderLayout() {
  return (
    <>
      <Header />
      <main>
        <Outlet />
      </main>
    </>
  );
}
