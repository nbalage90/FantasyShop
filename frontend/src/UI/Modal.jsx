import { createPortal } from 'react-dom';
import { useEffect, useRef } from 'react';

import './Modal.css';

/* eslint-disable react/prop-types */
export default function Modal({ open, onClose, children }) {
  const dialog = useRef();
  useEffect(() => {
    const modal = dialog.current;

    if (open) {
      modal.showModal();
    }

    return () => modal.close();
  }, [open]);

  return createPortal(
    <dialog
      ref={dialog}
      onClose={onClose}
    >
      {children}
    </dialog>,
    document.getElementById('modals')
  );
}
