import { useDispatch, useSelector } from 'react-redux';

import Modal from '../../UI/Modal';

import { uiActions } from '../../store/ui';

export default function Cart() {
  const cartItems = useSelector((state) => state.cart.items);
  const isCartOpen = useSelector((state) => state.ui.isCartOpen);
  const dispatch = useDispatch();

  const handleCloseDialogClick = () => {
    dispatch(uiActions.closeCart());
  };

  return (
    <Modal open={isCartOpen}>
      <article>
        <section>
          <ul>
            {cartItems.map((item) => (
              <li key={item.id}>
                <p>
                  {item.name} - {item.count} - ${item.totalPrice}
                </p>
              </li>
            ))}
          </ul>
        </section>
      </article>
      <button
        className="text-button"
        onClick={handleCloseDialogClick}
      >
        Close
      </button>
      <button className="button">Checkout</button>
    </Modal>
  );
}
